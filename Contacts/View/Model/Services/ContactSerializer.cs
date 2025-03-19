using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.Model.Services
{
    /// <summary>
    /// Сериализует и десериализует данные контакта.
    /// </summary>
    class ContactSerializer
    {
        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private string filePath = Path.Combine(
            System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments),
            "Contacts",
            "contacts.json"
        );
        /// <summary>
        /// Сохраняет данные контакта в файл.
        /// </summary>
        /// <param name="contact">Объект класса <see cref="Contact"/></param>
        public void SaveInFile(Contact contact)
        {
            string json = JsonConvert.SerializeObject(contact);
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, json);
        }
        /// <summary>
        /// Загружает данные контакта из файла.
        /// </summary>
        /// <returns>Возвращает загруженный контакт.</returns>
        /// <exception cref="FileNotFoundException"></exception>
        public Contact LoadFromFile()
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл не найден", filePath);

            string json = File.ReadAllText(filePath);
            Contact contact = JsonConvert.DeserializeObject<Contact>(json);
            return contact;
        }
    }
}
