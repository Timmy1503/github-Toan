﻿using ConnectDb.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDb.BLL
{
    public class CategoryBLL
    {
        SmartShopDbContext db = null;

        public CategoryBLL()
        {
            db = new SmartShopDbContext();
        }

        public long Insert(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return category.CategoryID;
        }
        public List<Category> ListAll()
        {
            return db.Categories.Where(x => x.Status == true).ToList();
        }

        public Category ViewDetail(long id)
        {
            return db.Categories.Find(id);
        }
    }
}
