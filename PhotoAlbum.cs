using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class PhotoAlbum
    {
        protected int pages;
        public PhotoAlbum(int pagesWanted)
        {
            this.pages = pagesWanted;
        }
        public PhotoAlbum()
        {
            pages = 24;
        }
        public int GetPhotoAlbumPages()
        {
            return pages;
        }
    }
}
