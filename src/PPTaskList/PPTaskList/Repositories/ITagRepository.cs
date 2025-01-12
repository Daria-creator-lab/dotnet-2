﻿using PPTask.Model;
using System.Collections.Generic;

namespace PPTask.Repositories
{
    /// <summary>
    /// Интерфейс репозиторий тегов 
    /// </summary>
    public interface ITagRepository
    {
        /// <summary>
        /// Метод добавления тега 
        /// </summary>
        /// <param name="tag">Тег</param>
        void AddTag(Tag tag);

        /// <summary>
        /// Метод получения всех тегов 
        /// </summary>
        /// <returns>Список тегов</returns>
        List<Tag> GetTags();

        /// <summary>
        /// Метод удаления тега  
        /// </summary>
        /// <param name="id">Идентификатор тега</param>
        void RemoveTag(int id);

        /// <summary>
        /// Метод удаления всех тегов  
        /// </summary>
        void RemoveAllTags();

        /// <summary>
        /// Метод записи данных в файл 
        /// </summary>
        System.Threading.Tasks.Task WriteToFileAsync();
    }
}
