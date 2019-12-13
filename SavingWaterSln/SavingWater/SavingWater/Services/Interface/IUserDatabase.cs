using SavingWater.Models;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace Water.Models
{
    public class newLocation : INotifyPropertyChanged
    {
        private Position _position;
        public string Description { get; }
        public string Address { get; }
        public Position Position
        {
            get => _position;
            set
            {
                if (!_position.Equals(value))
                {
                    _position = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Position)));
                }
            }
        }
        public newLocation(string address, string description, Position position)
        {
            Address = address;
            Description = description;
            Position = position;
        }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
    public interface IUserDatabase
    {
        Task<User> GetUser();
        Task<int> DeleteUser(User user);
        Task<int> UpdateUser(User user);
        Task<int> InsertUser(User user);
    }
}


