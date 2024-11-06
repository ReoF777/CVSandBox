using OpenCvSharp;
// 使用するWebカメラを選択するための試し用コード
using(var capture = new VideoCapture(0, VideoCaptureAPIs.DSHOW)) // カメラから画像を取得し、連続的に表示するプログラム
{
    using (var window = new Window("capture"))
    {
        Mat image = new Mat();
        while (true)
        {
            capture.Read(image);
            window.ShowImage(image);
            Cv2.WaitKey(1);
        }
    }
}
