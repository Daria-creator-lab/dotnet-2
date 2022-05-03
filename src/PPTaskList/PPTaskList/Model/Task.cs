﻿using System.Collections.Generic;

namespace PPTask.Controllers.Model
{
    /// <summary>
    /// Задачи 
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Идентификатор задачи
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// Заголовок задачи
        /// </summary>
        public string HeaderText { get; set; }

        /// <summary>
        /// Описание задачи
        /// </summary>
        public string TextDescription { get; set; }

        /// <summary>
        /// Идентификатор исполнителя
        /// </summary>
        public int ExecutorId { get; set; }

        /// <summary>
        /// Список идентификаторов тегов
        /// </summary>
        public List<int> TagsId { get; set; }

        /// <summary>
        /// Конструкор по умолчанию
        /// </summary>
        public Task()
        {
            HeaderText = string.Empty;
            TextDescription = string.Empty;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        public Task(string header, string text, int executorId, List<int> tagsId)
        {
            HeaderText = header;
            TextDescription = text;
            ExecutorId = executorId;
            TagsId = tagsId;
        }
    }
}