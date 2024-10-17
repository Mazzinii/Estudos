

using System.Collections.Generic;
using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;

namespace PaginationHelper.Entities
{
    public class PaginationHelper<T>
    {
        // TODO: Complete this class
  
        /// <summary>
        /// <param name="collection">A list of items</param>
        ///  </summary>
        public IList<T> Collection{ get; set; }
        
        //<summary>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        /// </summary>
        public int ItemsPerPage { get; set; }
        
        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        public PaginationHelper(IList<T> collection, int itemsPerPage)
        {
            Collection = collection;
            ItemsPerPage = itemsPerPage;
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        
        public int ItemCount
        {
            get
            {
            return Collection.Count;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
             return (int)Math.Ceiling(Collection.Count / (double)ItemsPerPage);  
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
           // verificar se o index da pagina existe
           // caso nao retornar -1
            if(pageIndex >= PageCount || pageIndex < 0){
                return -1;
            }
           // caso sim conferir quantos itens tem na pagina
           //atribuir os itens com base no valor maximo de itens por pagina
           double calc = (pageIndex + 1) * ItemsPerPage% ItemCount% ItemsPerPage; 
           return ItemsPerPage - (int)Math.Ceiling(calc);   
            
            
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= ItemCount){
                return -1;

            }
            double calc = itemIndex /  ItemsPerPage ;
            return (int)Math.Ceiling(calc);
            
        } 
            
    }
}