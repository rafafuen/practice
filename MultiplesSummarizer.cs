public class MultiplesSummarizer
{
    /// <summary>
    /// Gets the sum of all integers less than upperbound, which are divisible by all numbers in the provided
    /// divisors array.
    /// <summary>
    public int GetSumOfCompleteMultiples(int[] divisors, int upperBound)
    {
    var sum =0;
    for (var i =1; i < upperBound; i++){
        var isDivisibleByAnyDivisors = false;
        foreach (var divisor in divisors){
            if ( i % divisor ==0){
                isDivisibleByAnyDivisors = true;
                break;
            }
        }
        if (isDivisibleByAnyDivisors){
            sum += i;
        }
    }
    return sum;
    }
    /// <summary>
    /// Gets the sum of all numbers divisible by any of the divisors below an upper bound.
    /// <summary>
    ///<param name="divisors">An array of integers. This methiod will sum all numbers divisible by any of the integers</param>
    public int GetSumMultiples(int[] divisors, int upperBound){
    var sum =0;
    for (var i =1; i < upperBound; i++){
        var isDivisibleByAnyDivisors = false;
        foreach (var divisor in divisors){
            if ( i % divisor ==0){
                isDivisibleByAnyDivisors = true;
                break;
            }
        }
        if (isDivisibleByAnyDivisors){
            sum += i;
        }
    }
    return sum;
    }
}
