$(document).ready(function () {
    $(".DivResult").hide();
    $(".DivResultA").hide();
    $(".DivResultB").hide();
    $(".DivResultC").hide();
    $(".DivResultD").hide();
    $(".DivEmailSend").hide();
    var hv = $('#QuestionCount').val();
    $("#btnResultGet").click(function () {
        var a = 0, b = 0, c = 0, d = 0, hata = 0;
        for (var i = 1; i <= hv; i++) {
            if ($("input[name='" + i + "XX']:checked").val() === "A")
                a = a + 2;
            else if ($("input[name='" + i + "XX']:checked").val() === "B")
                b = b + 2;
            else if ($("input[name='" + i + "XX']:checked").val() === "C")
                c = c + 2;
            else if ($("input[name='" + i + "XX']:checked").val() === "D")
                d = d + 2;
            else {
                hata = 1;
                break;
            }

            if ($("input[name='" + i + "X']:checked").val() === "A")
                a++;
            else if ($("input[name='" + i + "X']:checked").val() === "B")
                b++;
            else if ($("input[name='" + i + "X']:checked").val() === "C")
                c++;
            else if ($("input[name='" + i + "X']:checked").val() === "D")
                d++;
        }
        if (hata == 1) {
            alert("Lütfen tüm sorularda XX seçeneklerinin işaretli olduğundan emin olunuz.");
        }
        else {
            $(".DivTest").toggle("Slow");
            var max = Math.max(a, b, c, d);
            if (max == a) {
                $(".DivResultA").show();
                $(".DivResultA").addClass("messageResult");
                $(".DivResultB").hide();
                $(".DivResultC").hide();
                $(".DivResultD").hide();
            }
            else if (max == b) {
                $(".DivResultA").hide();
                $(".DivResultB").show();
                $(".DivResultB").addClass("messageResult");
                $(".DivResultC").hide();
                $(".DivResultD").hide();
            }
            else if (max == c) {
                $(".DivResultA").hide();
                $(".DivResultB").hide();
                $(".DivResultC").show();
                $(".DivResultC").addClass("messageResult");

                $(".DivResultD").hide();
            }
            else if (max == d) {
                $(".DivResultA").hide();
                $(".DivResultB").hide();
                $(".DivResultC").hide();
                $(".DivResultD").show();
                $(".DivResultD").addClass("messageResult");

            }
            $(".DivResult").toggle("Slow");
        }
    });
    $("#btnEmailSend").click(function () {

        var mail = $("input[name=mail]").val();
        var kontrol1 = mail.indexOf("@");
        var kontrol2 = mail.lastIndexOf(".");
        if (kontrol1 > 0 && kontrol2 > kontrol1 && kontrol1 < mail.length) {
            var sonuc;
            $.ajax({
                url: "/Home/EmailSend",
                type: 'Get',
                data: { 'email': $("input[name=mail]").val(), 'message': $(".messageResult").html() },
                success: function (data) {
                    $(".DivResult").toggle("Slow");
                    $(".DivEmailSend").toggle("Slow");
                },
                error: function (reponse) {
                    alert("error : " + $("select#CityId").val() + reponse);
                }
            });
        } else {
            alert("E-Mail adresi geçersizLütfen geçerli bir eposta adresi giriniz.");
        }

    });
    //radio
    $("input[type=radio]").click(function () {
        var name = $(this).attr('name');
        if (name.endsWith("XX")) {
            if ($("input[name='" + name + "']:checked").val() === $("input[name='" + name.substring(0, name.length - 1) + "']:checked").val())
                $("input[name='" + name.substring(0, name.length - 1) + "']").prop("checked", false);
        }
        else if (name.endsWith("X")) {
            if ($("input[name='" + name + "']:checked").val() === $("input[name='" + name + "X']:checked").val())
                $("input[name='" + name + "X']").prop("checked", false);
        }
    });

});
////cİTY fİLL
//$('select#CityId').change(function () {
//    $('select#CountyId').children().remove().end().append('<option></option>');
//    $('select#AreaId').children().remove().end().append('<option></option>');
//    $('select#NeighborhoodId').children().remove().end().append('<option></option>');
//    $.ajax({
//        url: "/Address/CountyBasicJson",
//        type: 'Get',
//        data: { cityId: $("select#CityId").val() },
//        success: function (data) {
//            var markup = "<option></option>";
//            for (var x = 0; x < data.length; x++) {
//                markup += "<option value=" + data[x].Id + ">" + data[x].Name + "</option>";
//            }
//            $("#CountyId").html(markup).show();
//        },
//        error: function (reponse) {
//            alert("error : " + $("select#CityId").val() + reponse);
//        }
//    });
//});