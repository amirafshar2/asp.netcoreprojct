




$(ducument).ready(function () {
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
