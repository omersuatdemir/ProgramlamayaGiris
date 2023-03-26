for (var i = 1; i < 10; i++)
{
    for (var j = 1; j < 10; j++)
    {
        //console.log kullanamıyoruz çünkü o alt satıra geçiriyor.
        process.stdout.write((i * j) + " ");
    }
    console.log('\n')
}
