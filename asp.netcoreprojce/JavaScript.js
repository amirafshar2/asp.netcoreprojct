




$(document).ready(function () {

    $("#btn1").click(function () {

        swal("Sitemizde Verdiğiniz mail Adresi üzerinde bilgi ve haber e-postaları spam ölçülerini aşmayacak şekilde alacaksınız . ");
    });

    function Writer() {
        this.Name = "AS";
        this.About = "AS";
        this.Mail = "AS";
        this.Password = "aA1";
        this.Status = true;
    };

    $("#SaveBtn").click(function () {
        if ($("#password1").val() == $("#password2").val()) {

            var i = new Writer()
            {
                i.Name = $("#validationDefault01").val();
                i.About = "deneme";
                i.Mail = $("#validationDefault02").val();
                i.Password = $("#password1").val();
                i.Status = true;
            };
            Create(i);

        }
        else {
            swal("Şifreler uyumlu değil Lütfen tekrar deneyın");
        }
    });


    function Create(a) {
        $.ajax({
            url: '/Register/Index',
            type: 'POST',
            data: { Name: a.Name, About: a.About, Mail: a.Mail, Password: a.Password, Status: a.Status },
            beforeSend: function (xhr) {

                swal('İstek gönderiliyor...');

            },
            success: function (data) {
                swal("Kayıt Başarılı");
            },
            error: function (error) {
                swal('İstek başarısız oldu: ', error);
            }
        });
    };
 
});
