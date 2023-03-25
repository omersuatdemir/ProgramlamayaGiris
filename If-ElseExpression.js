const prompt = require('prompt-sync')();

const sayı = prompt('Bir sayı girin. ');

if (sayı > 50) {
    console.log('Girilen sayı 50 den büyük.');
}
else {
    if (sayı < 50) {
        console.log('Girilen sayı 50 den küçük.');
    }
    else {
        console.log('Girilen sayı 50 ye eşit.');
    }
}
