using System.Globalization;
using System.Resources;

namespace BindableResourceManager.Support
{
    /// <summary>
    /// バインド可能なリソースマネージャーを表します。
    /// </summary>
    public class BindableResourceManager
    {
        private ResourceManager _resourceManager;
        private CultureInfo _culture;

        /// <summary>
        /// <see cref="BindableResourceManager"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="res"><see cref="ResourceManager"/></param>
        public BindableResourceManager(ResourceManager res)
        {
            _resourceManager = res;
            _culture = CultureInfo.CurrentCulture;
        }

        /// <summary>
        /// 指定したリソースIDが示す文字列を、リソースマネージャーから適切な言語形式で取得します。
        /// </summary>
        /// <param name="index">リソースID</param>
        /// <returns>リソースIDが示す文字列　存在しない場合は空文字</returns>
        public string this[string index] => _resourceManager?.GetString(index, _culture) ?? "";

        /// <summary>
        /// カルチャを変更します。
        /// </summary>
        /// <param name="culture">カルチャ</param>
        public void ChangeCulture(CultureInfo culture)
        {
            _culture = culture;
        }
    }

}
