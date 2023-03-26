for (var i = 2; i <= 1000; i++)
{
    var kontrol = false;
    for (var j = 2; j < i; j++)
    {
        if ((i % j) == 0) {
            kontrol = true;
        }
    }
    if (!kontrol) {
        console.log(i);
    }
}
