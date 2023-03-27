var x = 5, y = 10;

//Aritmetik Operatörler
console.log(x + y); //toplama
console.log(x - y); //çıkarma
console.log(x * y); //çarpma
console.log(x ** y); //üslü sayı ifade eder bu durumda: 10^5
console.log(x / y); //bölme
console.log(x % y); //bölümden kalanı verir

//Arttırma - Azaltma Operatörleri
console.log(x++); //arttırma
console.log(x--); //azaltma

//Atama Operatörleri
x = 7; //x = 7
x += y; //x = x + y
x -= y; //x = x - y
x *= y; //x = x * y
x /= y; //x = x / y
x %= y; //x = x % y
x **= y; //x = x ** y

//Karşılaştırma Operatörleri
//Bu operatörler string değerleri için de kullanılabilir, onların değerleri alfabetik olarak karşılaştırılır.
console.log(x == y); //eşitse
console.log(x === y); //hem değer hem tip olarak eşitse
console.log(x != y); //eşit değilse
console.log(x !== y); //hem değer hem tip olarak eşit değilse
console.log(x < y); //küçükse
console.log(x > y); //büyükse
console.log(x <= y); //küçük veya eşitse
console.log(x >= y); //büyük veya eşitse

//String Birleştirme Operatörleri
var str1 = 'Hello ';
var str2 = 'World';
console.log(str1 + str2); //iki string değerini birleştirir
str1 += str2; //str1 = str1 + str2
console.log(str1);

//String ve Number Değerlerinin Toplanması
console.log(5 + 5); //10
console.log('5' + 5); //'55'
console.log('Hello' + 5); //'Hello5'

//Mantıksal Operatörler
console.log(true && false); //ve
console.log(true || false); //veya
console.log(!true); //değil
