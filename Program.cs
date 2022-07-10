using System;
namespace ConsoleApp24
{
    class Program
    {
        public static void Main(string[] args)
        {
            BigAlbum big = new();
                Console.WriteLine(big.GetPhotoAlbumPages());
            PhotoAlbum photo = new(100);
            Console.WriteLine(photo.GetPhotoAlbumPages());
            PhotoAlbum pho = new PhotoAlbum();
            Console.WriteLine(pho.GetPhotoAlbumPages() );
        }
    }
}