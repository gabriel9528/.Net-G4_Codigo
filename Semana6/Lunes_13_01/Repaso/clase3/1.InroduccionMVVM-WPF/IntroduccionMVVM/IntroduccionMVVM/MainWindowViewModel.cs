using System.ComponentModel;
using System.Windows.Input;
using System;
using IntroduccionMVVM;

public class MainWindowViewModel : INotifyPropertyChanged
{
    private string _firstName;
    private string _lastName;
    private string _fullName;

    //ICOMMAND
    public ICommand UpdateCommand { get; }

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            _firstName = value;
            OnPropertyChanged(nameof(FirstName));
            UpdateFullNameFromNames();
        }
    }

    public string LastName
    {
        get { return _lastName; }
        set
        {
            _lastName = value;
            OnPropertyChanged(nameof(LastName));
            UpdateFullNameFromNames();
        }
    }

    public string FullName
    {
        get { return _fullName; }
        set
        {
            if (_fullName != value)
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
                UpdateNamesFromFullName();
            }
        }
    }

    public MainWindowViewModel()
    {
        UpdateCommand = new RelayCommand(Update, CanUpdate);
        _firstName = "";
        _lastName = "";
        UpdateFullNameFromNames();
    }

    private void Update()
    {
        // Lógica de actualización, por ejemplo:
        FirstName = "Write the first name";
        LastName = "Write the last name";
    }

    private bool CanUpdate()
    {
        return !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName);
    }

    

    //Actualiza el nombre completo a partir de los nombres
    private void UpdateFullNameFromNames()
    {
        _fullName = $"{FirstName} {LastName}";
        OnPropertyChanged(nameof(FullName));
    }


    //Actualiza los nombres a partir del nombre completo
    private void UpdateNamesFromFullName()
    {
        var names = _fullName.Split(new[] { ' ' }, 2);
        if (names.Length == 2)
        {
            FirstName = names[0];
            LastName = names[1];
        }
        else
        {
            FirstName = _fullName;
            LastName = string.Empty;
        }
    }

    //INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
