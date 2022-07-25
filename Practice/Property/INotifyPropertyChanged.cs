using System.ComponentModel;

namespace Practice.Property
{
    //값이 변했을때 알려주는 역할을 하는 프로퍼티를 사용가능
    public class Person : INotifyPropertyChanged
    {
        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name must not be blank");
                if (value != firstName)
                {
                    firstName = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(FirstName)));
                }
            }
        }
        private string firstName;

        public event PropertyChangedEventHandler PropertyChanged;
        // 이후 이벤트를 PropertyChanged에 연결해서 사용하면 될듯
        // Docs 참고해서 나중에 좀더 이해해봐야할듯 https://docs.microsoft.com/ko-kr/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-6.0
    }
}
