using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ExpressionTrees
{

    // 식트리 기본
    // 람다와 func를 사용하여 EntityFramwordk 와 moq등에 쉽게 사용가능
    public class ExpressionTreeExample
    {
        public static void ExpressionTreeBasic()
        {
            //func를 사용한 기본 식트리
            Expression<Func<int, int>> addFive = (num) => num + 5;

            if (addFive.NodeType == ExpressionType.Lambda)
            {
                var lambdaExp = (LambdaExpression)addFive;

                var parameter = lambdaExp.Parameters.First();

                Console.WriteLine(parameter.Name);
                Console.WriteLine(parameter.Type);
            }

            // 식 트리 만들기
            // 1+ 2 식 생성
            var one = Expression.Constant(1, typeof(int));
            var two = Expression.Constant(2, typeof(int));
            var addition = Expression.Add(one, two);
            var lambda = Expression.Lambda(addition);

            // ExpressionType 열거형의 멤버를 확인하여 검색할 수 있는 노드를 결정합니다. 실제로 식 트리를 트래버스하고 이해하려는 경우에 도움이 됩니다.
            // Expression 클래스의 정적 멤버를 확인하여 식을 작성합니다.이러한 메서드는 자식 노드 집합에서 모든 식 형식을 작성할 수 있습니다.
            // ExpressionVisitor 클래스를 확인하여 수정된 식 트리를 작성합니다.

            // 람다식을 함수로 변환
            Expression<Func<int>> add = () => 1 + 2;
            var func = add.Compile(); // 식 생성
            var answer = func(); // 식 실행
            Console.WriteLine(answer);

            // 식도 지금 당장에는 쓸일 없을듯 하다
            // 이어서 학습하기 https://docs.microsoft.com/ko-kr/dotnet/csharp/expression-trees-interpreting

        }
    }
}
