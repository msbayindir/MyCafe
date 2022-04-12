using System;
namespace MyCafeDAL.ImageConverter
{
	public class ImageCon
	{
        public string ByteToImage(byte[] ProductImage)
        {

            string imreBase64Data = Convert.ToBase64String(ProductImage);
            string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data);

            return imgDataURL;
        }

        public byte[] ImageToByte(string imageName)
        {
            //Initialize a file stream to read the image file
            FileStream fs = new FileStream(imageName, FileMode.Open, FileAccess.Read);

            //Initialize a byte array with size of stream
            byte[] imgByteArr = new byte[fs.Length];

            //Read data from the file stream and put into the byte array
            fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));

            //Close a file stream
            fs.Close();

            return imgByteArr;
        }
    }
}

