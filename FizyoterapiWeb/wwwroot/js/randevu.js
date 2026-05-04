document.addEventListener('DOMContentLoaded', function () {
    var phoneInput = document.getElementById('phoneInput');
    if (!phoneInput) return;

    phoneInput.addEventListener('input', function () {
        // Sadece rakamları tut
        var digits = this.value.replace(/\D/g, '');

        // Maksimum 10 hane
        if (digits.length > 10) {
            digits = digits.substring(0, 10);
        }

        // 5XX XXX XX XX formatında boşluk ekle
        var formatted = '';
        if (digits.length <= 3) {
            formatted = digits;
        } else if (digits.length <= 6) {
            formatted = digits.substring(0, 3) + ' ' + digits.substring(3);
        } else if (digits.length <= 8) {
            formatted = digits.substring(0, 3) + ' ' + digits.substring(3, 6) + ' ' + digits.substring(6);
        } else {
            formatted = digits.substring(0, 3) + ' ' + digits.substring(3, 6) + ' ' + digits.substring(6, 8) + ' ' + digits.substring(8);
        }

        this.value = formatted;
    });
});
