using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace View.Model.Services
{
    /// <summary>
    /// Сериализует и десериализует данные контакта.
    /// </summary>
    internal class ContactSerializer
    {
        /// <summary>
        /// Директория.
        /// </summary>
        private string _directory = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Contacts");
        
        /// <summary>
        /// Название файла.
        /// </summary>
        private string _fileName = "contacts.json";

        /// <summary>
        /// Сохраняет данные контакта в файл.
        /// </summary>
        /// <param name="contact">Объект класса <see cref="Contact"/></param>
        public void SaveInFile(Contact contact)
        {
            string json = JsonConvert.SerializeObject(contact);
            Directory.CreateDirectory(_directory);
            File.WriteAllText(Path.Combine(_directory, _fileName), json);
        }

        /// <summary>
        /// Загружает данные контакта из файла.
        /// </summary>
        /// <returns>Возвращает загруженный контакт.</returns>
        /// <exception cref="FileNotFoundException"></exception>
        public Contact LoadFromFile()
        {
            string filePath = Path.Combine(_directory, _fileName);
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл не найден", filePath);

            string json = File.ReadAllText(filePath);
            Contact contact = JsonConvert.DeserializeObject<Contact>(json);
            return contact;
        }
    }
}
