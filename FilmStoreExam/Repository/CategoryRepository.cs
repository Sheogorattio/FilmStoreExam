﻿using FilmStoreExam.Data;
using FilmStoreExam.Interfaces;
using FilmStoreExam.Models;
using FilmStoreExam.Models.Pages;
using Microsoft.EntityFrameworkCore;

namespace FilmStoreExam.Repository
{
    public class CategoryRepository:ICategory
    {
        private ApplicationContext _context;

        public CategoryRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public PagedList<Category> GetCategories(QueryOptions options)
        {
            return new PagedList<Category>(_context.Categories, options);
        }
    }
}
