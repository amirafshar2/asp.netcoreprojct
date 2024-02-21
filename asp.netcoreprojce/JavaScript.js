











$(document).ready(function () {

    $("#savebtn").on("Click", function (e) {
        e.preventDefault();
        if ($("#pas1").text() === $("#pas2").text()) {
            var Deleteurl = $(this).attr("href");
            window.location.href = deleteUrl;
        } else {
            swal.fire({
                title: "Uyarı",
                text: "Şifreniz Uyuşmiyor! Tekrar Deneyın",
                icon: "warning",
                showCancelButton: false,
                confirmButtonColor: "#3085d6",
                cancelButtonColor: "#d33",
                confirmButtonText: "Tamam",

            });
        }
    });


});



$(document).ready(function () {
    $(".Delete").on("click", function (e) {
        e.preventDefault();
        var Deleteurl = '/Blog/BlogRemove/';
        swal.fire({
            title: "Emin misiniz?",
            text: "Bu işlemi geri alamayacaksınız!",
            icon: "warning",
            showCancelButton: true,
            confirmButtonColor: "#3085d6",
            cancelButtonColor: "#d33",
            confirmButtonText: "Evet, sil!",
            cancelButtonText: "İptal",
        }).then((result) => {
            if (result.isConfirmed) {
                // Kullanıcı "Evet" seçeneğini seçtiğinde, silme işlemini gerçekleştir
                window.location.href = deleteUrl;
            }
        });
    });

});









    $(document).ready(function () {
        function Comment() {
            this.UserName = "aa";
            this.Mail = "aa";
            this.Title = "aa";
            this.Content = "aa";
        }
        $("#savebtn").click(function () {
            var c = new Comment()
            {
                UserName = $("#nametxt").val();
                Mail = $("#emailtxt").val();
                Title = $("#titletxt").val();
                Content = $("#messagetxt").val();
            }
            $.ajax({
                url: '/Comment/PartialAddComment',
                type: 'POST',
                data: { UserName: c.UserName, Mail: c.Mail, Title: c.Title, Content: c.Content },
                beforeSend: function (xhr) {

                    console.log('İstek gönderiliyor...');

                },
                success: function (data) {
                    swal("Kayıt Başarılı");
                },
                error: function (error) {

                    console.log('İstek başarısız oldu: ', error);
                }
            });

        });

    });


$(document).ready(function () {
    function ReadAll(all) {
        $.ajax({
            url: '/Admin/Writer/Readall',
            type: 'POST',
            beforeSend: function (xhr) {
                console.log("istek gönderildi...")
            },
            success: function (data) {
                console.log(data);
                all(data);

            },
            error: function (error) {
                console.error("istek başarısız oldu");
            }
        });

       
    }

    function GetReadAll() {
        ReadAll(function (Data) {

            for (var i in Data) {
                var rowData = Data[i];
                $('#RecordTbl').append('<div class=" col-12 col-xs-12 col-sm-12 col-md-10 col-l-6 col-xl-6 table-responsive Recor"> <table class=" table    table-hover " "><tr  style="cursor:pointer"  data-id="' + rowData.id + '" data-Name="' + rowData.Name + '" data-Family="' + rowData.Family + '" data-Age="' + rowData.Age + '" ><td>' + JSON.stringify(rowData.id) + '</td><td>' + JSON.stringify(rowData.Name) + '</td><td>' + JSON.stringify(rowData.Family) + '</td><td>' + JSON.stringify(rowData.Age) + '</td> <td><input type="button" value="Delete"  class="btn btn-danger mt-1 DelBtn" /><input type="button" value="Update" id="" class="btn btn-success m-1  UpBtn" /></td> </table></div>')
            }
        });
    };




});


//$(document).ready(function () {
//    function Writer() {
//        this.Name = "AS";
//        this.About = "AS";
//        this.Mail = "AS";
//        this.Password = "aA1";
//        this.Status = true;
//    };

//    $("#SaveBtn").click(function () {
//        if ($("#password1").val() == $("#password2").val()) {

//            var i = new Writer()
//            {
//                i.Name = $("#validationDefault01").val();
//                i.About = $("#validationDefault03").val();
//                i.Mail = $("#validationDefault02").val();
//                i.Password = $("#password1").val();
//                i.Status = true;
//            };
//            Create(i);

//        }
//        else {
//            swal("Şifreler uyumlu değil Lütfen tekrar deneyın");
//        }

//    });
//    function Create(a) {
//        $.ajax({
//            url: '/Register/Index.cshtml',
//            type: 'POST',
//            data: { Name: a.Name, About: a.About, Mail: a.Mail, Password: a.Password, Status: a.Status },
//            beforeSend: function (xhr) {

//                console.log('İstek gönderiliyor...');

//            },
//            success: function (data) {
//                swal("Kayıt Başarılı");
//            },
//            error: function (error) {

//                console.log('İstek başarısız oldu: ', error);
//            }
//        });
//    };
//});
