num = int(input("bir sayı girin "))
control = True
for x in range(2, num):
    if num % x == 0:
        control = False

if control:
    print("sayı asal")
else:
    print("sayı asal değil")
