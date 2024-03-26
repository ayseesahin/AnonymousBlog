using System;
using AnonymousBlog.Entity.DTOs.Images;
using AnonymousBlog.Entity.Enums;
using Microsoft.AspNetCore.Http;

namespace AnonymousBlog.Service.Helpers.Images
{
	public interface IImageHelper
	{
		Task<ImageUploadedDto> Upload(string name, IFormFile imageFile,ImageType imageType, string folderName = null);
		void Delete(string imageName);
	}
}

