namespace PragmaticSegmenterNet.Tests.Unit.Languages
{
    using Xunit;

    public class ChineseLanguageTests
    {
        [Fact]
        public void CorrectlySegmentsText001()
        {
            var result = Segmenter.Segment("（项目可视化平台视屏介绍后）首先为大家展示的光导管，它可开启关闭，没有使用电力，将自然光线引入室内，减少白天照明能耗；其次是断桥门窗系统，隔音效果好，气密性能强，大家可以感受一下开关窗户不同的噪声体验，密闭的窗户也能带来更好的节能效果；第三是三银双中空玻璃与普通中空玻璃隔热性能对比，各位领导可以直接将手放在两个不同玻璃下面感受一下，我们通过热源模拟太阳红外线热量，可以明显感受到三银双中空玻璃的隔热效果非常优秀；第四是48v直流电体验，来自于屋顶的太阳能光伏电池，我们在这个区域内使用的都是直流电，48V直流电是一个安全电压，大家可以看一下正负极接上导线后灯正常点亮，我用手触摸正负极不会触电；第五是可透光的碲化镉光伏玻璃，应用于双碳中心中庭天井；第六是超双疏自清洁辐射制冷涂料。模型展示区为4项，分别是：结构装配式、模块化设计、预冷通风技术、工位送风系统。本项目为装配式整体框架结构，绿色施工，保护环境、节约资源。", Language.Chinese);
            Assert.Equal(new[] { "安永已聯繫周怡安親屬，協助辦理簽證相關事宜，周怡安家屬1月1日晚間搭乘東方航空班機抵達上海，他們步入入境大廳時神情落寞、不發一語。", "周怡安來自台中，去年剛從元智大學畢業，同年9月加入安永。" }, result);
        }

        [Fact]
        public void CorrectlySegmentsText002()
        {
            var result = Segmenter.Segment("我们明天一起去看《摔跤吧！爸爸》好吗？好！", Language.Chinese);
            Assert.Equal(new[] { "我们明天一起去看《摔跤吧！爸爸》好吗？", "好！" }, result);
        }
    }
}
