#python中注意事项
#1.#表示注释；\n表示换行
#2.引用外界包与java一样 使用import
import math
print("--Python学习之旅--")

#转换函数
print("\n转换函数")
print(int('3'))
print(str(1))
print(float(3))

#算数操作符 (+ - * / // **)
#1.操作符运算顺序:无括号先乘除和加减 有括号按照括号顺序执行 2.python中的/是精确计算;若要求整数部分用// 2.**指幂
print("\n算数操作符 (+ - * / // **)")
a = b = c = 100   #批量多参数赋值
print(a)
a+=20
print(a)
print(b)
print(c)
print(1 + 2)
print(10 - 1)
print(10 * 2)
print(10 / 2.5) 
print(10 // 2.5) 
print(10 ** 2)
print(100 + 2 - 1 * 10 / 2)

#for循环
print("\nfor循环")
for x in [10,20,30]:
    print(x)

#判断条件语句
print("\n判断条件语句")
inputNum = input("if判断语句测试。请输入一个数字：")
if int(inputNum) > 10:  #这里如果直接写 if inputNum > 10 会出错 必须将输入值inputNum转换为int后才能比较
    print("输入值大于10")
else:
    if int(inputNum) > 5:
        print("输入值大于5小于10")
    else:
        if int(inputNum) > 0:
            print("输入值大于0小于5")

if int(inputNum) > 10:
    print("输入值大于10")
elif int(inputNum) > 5:
    print("输入值大于5小于10")
elif int(inputNum) > 0:
    print("输入值大于0小于5")

#三元操作符
print("\n三元操作符")
x,y = 4,5  
if x < y:
    small = x
else :
    small = y
small = x if x < y else y  #三元运算符改造
print(small)

#assert 断言 主要是在调试中抛出异常 例如：3 > 4 结果为false ; assert 3 > 4 则会抛出异常
print("\nassert断言")
rst = 3 > 4
print(rst)

