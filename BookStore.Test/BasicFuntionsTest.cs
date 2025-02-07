using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models;


namespace BookStore.Test
{
       public class BasicFuntionsTest
    {
        [Fact]
        public void TestGetBookByTitle()
        {
  
            Book? testBook = BasicFunctions.GetBookByTitle("");

   
          
            Assert.Equal("", testBook.Title);
        }

        
    }
}
