var testdemoshop = "我是原始檔案";

$("body").click(function (e) {
  e.preventDefault();
  $.ajax({
    type: "GET",
    url: "/url",
    data: "name=John&location=Bostaoaan",
    dataType: "json",
    success: function (data) {

    }
  });
});
