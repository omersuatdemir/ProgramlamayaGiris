const prompt = require('prompt-sync')();

const sayı = Number(prompt('Bir sayı girin. '));


switch (sayı) {
    case 5:
        console.log("Girdiğiniz sayı 5");
        break;

    case 10:
        console.log("Girdiğiniz sayı 10");
        break;

    case 15:
        console.log("Girdiğiniz sayı 15");
        break;
    default:
        console.log("Girdiğiniz sayı listede yok.");
        break;
}
