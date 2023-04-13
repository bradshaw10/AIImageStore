﻿using Microsoft.AspNetCore.Mvc;

namespace AIImageStoreServer.Repositories
{
    public interface ICategoryRepository
    {
        Task<IActionResult> AddCategory();
        Task<IActionResult> DeleteCategory(string CategoryId);
        Task<IActionResult> EditCategoryName(string CategoryId);
    }
    public class CategoryRepository
        : ICategoryRepository
    {

        public CategoryRepository()
        {
        }

        public Task<IActionResult> AddCategory()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> DeleteCategory(string CategoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> EditCategoryName(string CategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
