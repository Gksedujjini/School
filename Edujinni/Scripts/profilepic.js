$(document).ready(function () {
    $('#upload-data').click(function () {
        $('#getfile').trigger('click');
        return false;
    });

    $('#upload-data1').click(function () {
        $('#getfile1').trigger('click');
        return false;
    });
    $('#upload-data').mouseover(function () {
        $('#upload-data').css('color', 'blue');
    });
    $('#upload-data').mouseout(function () {
        $('#upload-data').css('color', 'black');
    });
    $('#upload-data1').mouseover(function () {
        $('#upload-data1').css('color', 'blue');
    });
    $('#upload-data1').mouseout(function () {
        $('#upload-data1').css('color', 'black');
    });
});