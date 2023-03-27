
//Değişken Atama
let a = 5; //daha sonra değişecek değişkenlerde kullanılır
var b = 10; //genelde tarayıcılarda kullanılır
const c = 15; //daha sonradan değişemez (constant = sabit)
d = 20; //undeclared variables (tanımsız değişken)

console.log(a);
console.log(b);
console.log(c);
console.log(d);

//Undefined Value (Tanımsız Değer)
var e;
console.log(e); //undefined

let f, g, h = 25; //virgül ile ayırarak, tek satırda çoklu tanımlama
f = 30, g = 35; //tanımlamadan sonra değer atama (aynı zamanda yine tek satırda olabilir.)
console.log(f);
console.log(g);
console.log(h);

//Re-Declaring (Yeniden Tanımlama), let ve const'da çalışmaz.
var i = 40;
console.log(i);
var i = 45; //yeni değer atanıyor
console.log(i);
var i; //değer atanmadığı için önceki değerini koruyor.
console.log(i);

//identifiers - değişken isimleri istisnası
var $deger1 = 50; // $ ve _ değerleri string olarak kabul edildiğinden, tanımlamalarda kullanılabilir.
var _deger2 = 55;

console.log($deger1);
console.log(_deger2);
