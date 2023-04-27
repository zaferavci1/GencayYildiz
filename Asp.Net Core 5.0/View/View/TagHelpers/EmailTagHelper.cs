using Microsoft.AspNetCore.Razor.TagHelpers;

namespace View.TagHelpers
{
    [HtmlTargetElement("mail1")]// TagHelper'ın sınıf isminden farklı olması için kullanılıyor.
    public class EmailTagHelper : TagHelper//Bir sınıfın TagHelper olabilmesi için TagHelper sınıfından türemesi gereklidir.
    {
        public string Mail { get; set; }
        public string Display { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
            //TagHelper'ın operasyonunun işlevini gerçekleşmesi için Proccess metodunun override edilmesi gereklidir.
        {
            //context parametresi bize html dosyasında verdiğimiz değerleri getirecek. İlgili TagHelper'ı getirebilmekte. Attributelar getiriyor
            //output ilgili attribute'ların çıktısını bize veriyor.
            output.TagName = "a";
            output.Attributes.Add("href", $"mailto:{Mail}");
            output.Content.Append(Display);
        }
    }
}
