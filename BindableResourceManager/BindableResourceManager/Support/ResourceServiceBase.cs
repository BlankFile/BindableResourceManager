using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace BindableResourceManager.Support
{
    /// <summary>
    /// リソースの変更通知機能を提供します。
    /// </summary>
    public abstract class ResourceServiceBase : INotifyPropertyChanged
    {
        /// <summary>
        /// <see cref="ResourceServiceBase"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="resourceManager"><see cref="ResourceManager"/></param>
        protected ResourceServiceBase(ResourceManager resourceManager)
        {
            Manager = new BindableResourceManager(resourceManager);
        }

        /// <summary>
        /// バインド可能なリソースマネージャー
        /// </summary>
        public BindableResourceManager Manager { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// カルチャを変更します。
        /// </summary>
        /// <param name="culture">カルチャ</param>
        public virtual void ChangeCulture(CultureInfo culture)
        {
            Manager.ChangeCulture(culture);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Manager)));
        }
    }
}
