const prompt = require('prompt-sync')();

const sayi1 = prompt('Birinci sayıyı girin.');
const sayi2 = prompt('İkinci sayıyı girin.');

console.log('İki sayıdan büyük olanı: ' + ((sayi1 >= sayi2) ? sayi1 : sayi2));
