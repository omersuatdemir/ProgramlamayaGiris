const prompt = require("prompt-sync")({ sigint: true });

let cm = prompt('Boyunuzu girin (cm)...');
let m = cm / 100;

let kg = prompt('Kilonuzu girin (kg)...');

let indeks = kg/(m*m);

console.log('Vücut Kitle İndeksi : ' + indeks);

if (indeks < 18.5)
{
    console.log('İdeal kilonun altında.');
}
if (indeks >= 18.5 && indeks < 25)
{
    console.log('İdeal kiloda.');
}
if (indeks >= 25 && indeks < 29)
{
    console.log('İdeal kilonun üstünde.');
}
if (indeks >= 30 && indeks < 35)
{
    console.log('Obez.');
}
if (indeks > 35)
{
    console.log('Aşırı Obez.');
}
