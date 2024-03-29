using System;
namespace AnonymousBlog.Web.ResultMessages
{
	public static class Messages
	{
		public static class Article
		{
			public static string Add(string articleTitle)
			{
				return $"{articleTitle} başlıklı makale başarıyla eklenmiştir.";
			}

            public static string Update(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla güncellenmiştir.";
            }

            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla silinmiştir.";
            }
        }

        public static class Category
        {
            public static string Add(string categoryTitle)
            {
                return $"{categoryTitle} başlıklı makale başarıyla eklenmiştir.";
            }

            public static string Update(string categoryTitle)
            {
                return $"{categoryTitle} başlıklı makale başarıyla güncellenmiştir.";
            }

            public static string Delete(string categoryTitle)
            {
                return $"{categoryTitle} başlıklı makale başarıyla silinmiştir.";
            }
        }
    }
}

