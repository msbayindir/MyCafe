using System;
namespace MyCafeBusinessLayer.ImageConverter
{
	public class ByteToImage
	{
		public ByteToImage()
		{
		}
		public string ByteConversion(byte[] byteArray)
        {
			byte[] photoBack = byteArray;
			string imreBase64Data = Convert.ToBase64String(photoBack);
			string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data);

			return imgDataURL;
		}
			


	}
}

