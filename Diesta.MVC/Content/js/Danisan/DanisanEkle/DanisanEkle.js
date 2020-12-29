$('#btnTemelBilgiModal').click(function () {
    var url = $('#modal-anket-temelBilgi').data('url');

    $.get(url, function (data) {
        $('#modal-anket-temelBilgi').html(data);

        $('#modal-anket-temelBilgi').modal('show');
    });
});
$('#btnDiyetOykusu').click(function () {
    var url = $('#modal-anket-diyetOykusu').data('url');

    $.get(url, function (data) {
        $('#modal-anket-diyetOykusu').html(data);

        $('#modal-anket-diyetOykusu').modal('show');
    });
});

$('#btnBesinAliskanlik').click(function () {
    var url = $('#modal-anket-besinAliskanlik').data('url');

    $.get(url, function (data) {
        $('#modal-anket-besinAliskanlik').html(data);

        $('#modal-anket-besinAliskanlik').modal('show');
    });
});
$('#btnGecmis').click(function () {
    var url = $('#modal-anket-gecmis').data('url');

    $.get(url, function (data) {
        $('#modal-anket-gecmis').html(data);

        $('#modal-anket-gecmis').modal('show');
    });
});
$('#btnGenelAliskanlik').click(function () {
    var url = $('#modal-anket-genelAliskanlik').data('url');

    $.get(url, function (data) {
        $('#modal-anket-genelAliskanlik').html(data);

        $('#modal-anket-genelAliskanlik').modal('show');
    });
});
$('#btnHareket').click(function () {
    var url = $('#modal-anket-hareket').data('url');

    $.get(url, function (data) {
        $('#modal-anket-hareket').html(data);

        $('#modal-anket-hareket').modal('show');
    });
});
$('#btnKisisel').click(function () {
    var url = $('#modal-anket-kisisel').data('url');

    $.get(url, function (data) {
        $('#modal-anket-kisisel').html(data);

        $('#modal-anket-kisisel').modal('show');
    });
});
$('#btnAntropometri').click(function () {
    var url = $('#modal-anket-antropometri').data('url');

    $.get(url, function (data) {
        $('#modal-anket-antropometri').html(data);

        $('#modal-anket-antropometri').modal('show');
    });
});
$('#btnMenu').click(function () {
    var url = $('#modal-anket-menu').data('url');

    $.get(url, function (data) {
        $('#modal-anket-menu').html(data);

        $('#modal-anket-menu').modal('show');
    });
});
$('#btnEgzersiz').click(function () {
    var url = $('#modal-anket-egzersiz').data('url');

    $.get(url, function (data) {
        $('#modal-anket-egzersiz').html(data);

        $('#modal-anket-egzersiz').modal('show');
    });
});
$('#btnFinans').click(function () {
    var url = $('#modal-anket-finans').data('url');

    $.get(url, function (data) {
        $('#modal-anket-finans').html(data);

        $('#modal-anket-finans').modal('show');
    });
});
$('#btnNot').click(function () {
    var url = $('#modal-anket-not').data('url');

    $.get(url, function (data) {
        $('#modal-anket-not').html(data);

        $('#modal-anket-not').modal('show');
    });
});