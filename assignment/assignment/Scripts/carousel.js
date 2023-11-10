document.addEventListener("DOMContentLoaded", function() { 
var locationSelector = document.getElementById("locationSelector");

// 获取row2内容的ul元素
var rowContent = document.getElementById("rowContent");

// 添加change事件监听器
locationSelector.addEventListener("change", function () {
    // 获取所选选项的值
    var selectedLocation = locationSelector.value;
    setTimeout(function () {
        // 根据所选选项的值更新row2内容
        if (selectedLocation === "Beijing") {
            rowContent.innerHTML = `
                <li>
                     <a href="@Url.Action("Details", "Destinations", new { id = "4" })">
                        <span>Eight Immortals Mountain</span>
                         <img src="../Content/img/bjbg1.jpg">

                    </a> 
                </li>
                <li>
                     <a href="@Url.Action("Details", "Destinations", new { id = "5" })">
                        <span>Panshan</span>
                        <img src="../Content/img/bjbg2.jpg">

                    </a>
                </li>
                <li>
                     <a href="@Url.Action("Details", "Destinations", new { id = "6" })">
                        <span>Yangliuqing Town in Beijing</span>
                        <img src="../Content/img/bjbg3.jpg">
                    </a>
                </li>
            `;
        } else if (selectedLocation === "Shanghai") {
            rowContent.innerHTML = `
                <li>
                   <a href="@Url.Action("Details", "Destinations", new { id = "7" })">
                        <span>The Bund</span>
                        <img src="../Content/img/shbg1.jpg">
                    </a>
                </li>
                <li>
                    <a href="@Url.Action("Details", "Destinations", new { id = "8" })">
                        <span>Yu Garden</span>
                        <img src="../Content/img/shbg2.jpg">
                    </a>
                </li>
                <li>
                    <a href="@Url.Action("Details", "Destinations", new { id = "9" })">
                        <span>Oriental Pearl Radio & Television Tower</span>
                        <img src="../Content/img/shbg3.jpg">
                    </a>
                </li>
            `;
        }else if (selectedLocation === "Guangzhou") {
            rowContent.innerHTML = `
                <li>
                    <a href="@Url.Action("Details", "Destinations", new { id = "10" })">
                        <span>Canton Tower</span>
                        <img src="../Content/img/gzbg1.jpg">
                    </a>
                </li>
                <li>
                    <<a href="@Url.Action("Details", "Destinations", new { id = "11" })">
                        <span>Chen Clan Ancestral Hall</span>
                        <img src="../Content/img/gzbg2.jpg">
                    </a>
                </li>
                <li>
                   <a href="@Url.Action("Details", "Destinations", new { id = "12" })">
                        <span>Shamian Island</span>
                        <img src="../Content/img/gzbg3.jpg">
                    </a>
                </li>
            `;
        }else if (selectedLocation === "Nanjing") {
            rowContent.innerHTML = `
                <li>
                   <a href="@Url.Action("Details", "Destinations", new { id = "13" })">
                        <span>Qixia Mountain</span>
                        <img src="../Content/img/njbg1.jpg">
                    </a>
                </li>
                <li>
                    <a href="@Url.Action("Details", "Destinations", new { id = "14" })">
                        <span>Presidential Palace of Nanjing</span>
                        <img src="../Content/img/njbg2.jpg">
                    </a>
                </li>
                <li>
                    <a href="@Url.Action("Details", "Destinations", new { id = "15" })">
                        <span>Laomendong Historic District</span>
                        <img src="../Content/img/njbg3.jpg">
                    </a>
                </li>
            `;
        }else if (selectedLocation === "Tianjing") {
            rowContent.innerHTML = `
                <li>
                  <a href="@Url.Action("Details", "Destinations", new { id = "1" })">
                        <span>Eye of Tianjin</span>
                        <img src="../Content/img/tjbg1.jpg">
                    </a>
                </li>
                <li>
                    <a href="@Url.Action("Details", "Destinations", new { id = "2" })">
                        <span>Italian Style Town</span>
                        <img src="../Content/img/tjbg2.jpg">
                    </a>
                </li>
                <li>
                    <a href="@Url.Action("Details", "Destinations", new { id = "3" })">
                        <span>Porcelain house</span>
                        <img src="../Content/img/tjbg3.jpg">
                    </a>
                </li>
            `;
        }

    }); 
});

});

