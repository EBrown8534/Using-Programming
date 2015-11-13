#include "stdafx.h"
#include <stdio.h>
#include <Windows.h>

#define ITERATIONS 500000
#define GET_START_TIME QueryPerformanceCounter(&StartingTime);
#define GET_END_TIME QueryPerformanceCounter(&EndingTime);
#define CALC_DIFF_TIME ElapsedMicroseconds.QuadPart = EndingTime.QuadPart - StartingTime.QuadPart; ElapsedMicroseconds.QuadPart *= 1000000; ElapsedMicroseconds.QuadPart /= Frequency.QuadPart;

int main()
{
    short results[ITERATIONS];
    const int n = 5;
    int m = 5;
    LARGE_INTEGER StartingTime, EndingTime, ElapsedMicroseconds;
    LARGE_INTEGER Frequency;
	
    QueryPerformanceFrequency(&Frequency);

    // This loop seems to take about 1400 us on my computer.
    printf("Beginning loop over %i iterations with n constant.\n", ITERATIONS);

    GET_START_TIME;

    for (int i = 0; i < ITERATIONS; i++)
    {
        int statement = i % 10;

        if (statement == 0)
            results[i] = n * 0;
        else if (statement == 4)
            results[i] = n * 4;
        else if (statement == 2)
            results[i] = n * 2;
        else if (statement == 5)
            results[i] = n * 5;
        else if (statement == 7)
            results[i] = n * 7;
        else if (statement == 6)
            results[i] = n * 6;
        else if (statement == 1)
            results[i] = n * 1;
        else if (statement == 3)
            results[i] = n * 3;
        else if (statement == 9)
            results[i] = n * 9;
        else if (statement == 8)
            results[i] = n * 8;
    }

    GET_END_TIME;
    CALC_DIFF_TIME;

    printf("Finished in %lld us.\n", ElapsedMicroseconds.QuadPart);

    // This one takes about 800 us on my computer.
    printf("Beginning loop over %i iterations with m variable.\n", ITERATIONS);

    GET_START_TIME;

    for (int i = 0; i < ITERATIONS; i++)
    {
        int statement = i % 10;

        if (statement == 0)
            results[i] = m * 0;
        else if (statement == 4)
            results[i] = m * 4;
        else if (statement == 2)
            results[i] = m * 2;
        else if (statement == 5)
            results[i] = m * 5;
        else if (statement == 7)
            results[i] = m * 7;
        else if (statement == 6)
            results[i] = m * 6;
        else if (statement == 1)
            results[i] = m * 1;
        else if (statement == 3)
            results[i] = m * 3;
        else if (statement == 9)
            results[i] = m * 9;
        else if (statement == 8)
            results[i] = m * 8;
    }

    GET_END_TIME;
    CALC_DIFF_TIME;

    printf("Finished in %lld us.\n", ElapsedMicroseconds.QuadPart);

    getchar();

    return 0;
}

