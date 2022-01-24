
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.IO.Ports;
using System.Speech.Synthesis;

namespace smple_face_recognition_app
{
    public partial class Form1 : System.Windows.Forms.Form

    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        private SerialPort myport1;
        #region Variables
        private Capture VideoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        ///step 2
        ///
        private bool facesDetectionEnabled = false;
        CascadeClassifier faceCasacdeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
        bool EnableSaveImage = false;

        private bool isTrained = false;
        EigenFaceRecognizer recognizer;
        List<string> PersonsNames = new List<string>();


        #endregion

        public Form1()
        {
            InitializeComponent();

            btnRecognize.Enabled = false;
            btnspech.Enabled = false;
            btnserver.Enabled = false;
            ss.SpeakAsync("hallo this program is very security pleas let me recognise your face ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            ss.SpeakAsync("pleac click on detect face");
            if (VideoCapture != null) VideoCapture.Dispose();
            VideoCapture = new Capture();
            Application.Idle += processFrame;
            //   VideoCapture = new Capture();
            // VideoCapture.ImageGrabbed += processFrame;
            // VideoCapture.Start();
        }

        private void processFrame(object sender, EventArgs e)
        {
            //step 1 video captureالخطوة 1 التقاط الفيديو   
            if (VideoCapture != null && VideoCapture.Ptr != IntPtr.Zero)
            {
                VideoCapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);
                //step 2 face drtection كشف الوجه
                if (facesDetectionEnabled)
                {
                    //convert from bgr to gray image التحويل من bgr إلى صورة رمادية
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                    //enhance the image to better result تعزيز الصورة إلى نتيجة أفضل
                    CvInvoke.EqualizeHist(grayImage, grayImage);
                    Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                    //if faces detected إذا تم الكشف عن الوجوه
                    if (faces.Length > 0)
                    {
                        foreach (var face in faces)
                        {
                            //draw square around each face رسم مربع حول كل وجه
                            // CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                            //step 3 add person
                            //assign the face to the picture box face picDetected تعيين الوجه إلى وجه مربع الصورة picDetected
                            Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            picDetected.SizeMode = PictureBoxSizeMode.StretchImage;
                            picDetected.Image = resultImage.Bitmap;
                            if (EnableSaveImage)
                            {

                                //we will create a directory if dose not existes /سنقوم بإنشاء دليل إذا لم تكن الجرعة موجودة
                                string path = Directory.GetCurrentDirectory() + @"\TrainedImages2";
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);

                                //to avoid Gui hangs we will use another task  لتجنب تعليق Gui سوف نستخدم مهمة أخرى
                                Task.Factory.StartNew(() =>
                                {
                                    //we will save 10 image with delay a second for each image سوف نقوم بحفظ 10 صورة مع تأخير ثانية لكل صورة
                                    for (int i = 0; i < 10; i++)
                                    {
                                        resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + txtPersonalName.Text + DateTime.Now.ToString("dd-mm-yyyy-hh-ss") + ".jpg");
                                        Thread.Sleep(1000);

                                    }

                                });
                            }
                            EnableSaveImage = false;

                            if (btnAddPerson.InvokeRequired)
                            {
                                btnAddPerson.Invoke(new ThreadStart(delegate {
                                    btnAddPerson.Enabled = true;
                                }));
                            }
                            //
                            // Step 5: Recognize the face الخطوة الخامسة: التعرف على الوجه
                            if (isTrained)
                            {
                                Image<Gray, byte> grayFaceResult = resultImage.Convert<Gray, byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                pictureBox1.Image = grayFaceResult.Bitmap;
                                pictureBox2.Image = TrainedFaces[result.Label].Bitmap;
                                Debug.WriteLine(result.Label + ". " + result.Distance);






                                //Here results found known faces هنا وجدت النتائج وجوه معروفة
                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);

                                    ////////arduino 
                                    btnRecognize.Enabled = true;
                                    btnspech.Enabled = true;
                                    btnserver.Enabled = true;








                                }
                                //here results did not found any know faces هنا لم يتم العثور على النتائج أي وجوه تعرف
                              
                            }



                        }



                    }

                }
                //render the video capture into the picture box pic capture تقديم التقاط الفيديو في صورة مربع التقاط الموافقة المسبقة عن علم
                picCapture.Image = currentFrame.Bitmap;
                //dispose the current frame after processing it to reduce the memory consumption التخلص من الإطار الحالي بعد معالجته لتقليل استهلاك الذاكرة

            }
            if (currentFrame != null) { currentFrame.Dispose(); }

        }

        private void btnDetectFaces_Click(object sender, EventArgs e)
        {/////////
            facesDetectionEnabled = true;
            ss.SpeakAsync("if you want to add person  pleac enter name this person after that click on add person");

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            //btnSave.Enabled = true;
            btnAddPerson.Enabled = false;
            EnableSaveImage = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ss.SpeakAsync("the  person is saved   click on Recognize ");
            btnSave.Enabled = false;
            btnAddPerson.Enabled = true;
            EnableSaveImage = false;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();

            ss.SpeakAsync("hello" + txtPersonalName.Text + "you can use this control panel");

        }
        //Step 4: train Images .. we will use the saved images from the previous example الخطوة 4: صور القطار .. سوف نستخدم الصور المحفوظة من المثال السابق 
        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages2";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count() > 0)
                {
                    // recognizer = new EigenFaceRecognizer(ImagesCount,Threshold);
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());

                    isTrained = true;
                    Debug.WriteLine(ImagesCount);
                    Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + ex.Message);
                return false;
            }

        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Users/Majd Hammoud/Desktop/task/spech/setup.exe");
            ss.SpeakAsync("in this section you can controling in any device connected with arduino in the port");
        }

        private void btnspech_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Users/Majd Hammoud/source/repos/spech/spech/obj/Debug/spech.exe");
            ss.SpeakAsync("in this section you can controling in any device and open any program with speech recognition ");
        }

        private void btnserver_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Users/Majd Hammoud/Desktop/task/chrome1");
            ss.SpeakAsync("in this section you can controling in any laptop or computer connected on the same wifi or network");
        }

        private void picCapture_Click(object sender, EventArgs e)
        {

        }

        private void picDetected_Click(object sender, EventArgs e)
        {

        }

        private void txtPersonalName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
