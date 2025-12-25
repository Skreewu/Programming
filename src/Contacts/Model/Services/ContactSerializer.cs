using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;

namespace Model.Services
{
    /// <summary>
    /// Сериализует и десериализует коллекцию контактов.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Директория для хранения файлов.
        /// </summary>
        private readonly string _directory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "Contacts");

        /// <summary>
        /// Название файла для хранения контактов.
        /// </summary>
        private readonly string _fileName = "contacts.json";

        /// <summary>
        /// Полный путь к файлу.
        /// </summary>
        private string _fullPath => Path.Combine(_directory, _fileName);

        /// <summary>
        /// Сохраняет коллекцию контактов в файл.
        /// </summary>
        /// <param name="contacts">Коллекция контактов для сохранения.</param>
        public void Save(ObservableCollection<Contact> contacts)
        {
            string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            Directory.CreateDirectory(_directory);
            File.WriteAllText(_fullPath, json);
        }

        /// <summary>
        /// Загружает коллекцию контактов из файла.
        /// </summary>
        /// <returns>Загруженная коллекция контактов.</returns>
        public ObservableCollection<Contact> Load()
        {
            if (!File.Exists(_fullPath))
                return new ObservableCollection<Contact>();

            string json = File.ReadAllText(_fullPath);
            var contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(json);
            return contacts ?? new ObservableCollection<Contact>();
        }
    }
}