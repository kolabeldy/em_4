namespace em.ViewModels.Base
{
    public abstract class TittledViewModel : ViewModelBase
    {
        #region Tittle : string - Заголовок

        /// <summary>Заголовок</summary>
        private string _Tittle;

        /// <summary>Заголовок</summary>
        public string Tittle { get => _Tittle; set => Set(ref _Tittle, value); }

        #endregion
    }
}
