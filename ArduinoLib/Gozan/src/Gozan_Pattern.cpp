#include "Gozan.h"

Pattern::Pattern()
{
    data = nullptr;
}

Pattern::Pattern(PatternData const *pattern)
{
    data = pattern;
}

uint16_t Pattern::getMaxSequence(void)
{
    if (data == nullptr)
    {
        return 0;
    }
    return data->max_sequence;
}

uint16_t Pattern::getLedLength(void)
{
    if (data == nullptr)
    {
        return 0;
    }
    return data->led_length;
}

int32_t Pattern::getShowTime(uint16_t sequence)
{
    if (data == nullptr)
    {
        return SHOW_INFINITY;
    }

    int32_t dat_size = sizeof(data->show_time) / sizeof(data->show_time[0]);

    if (sequence < dat_size)
    {
        return data->show_time[sequence];
    }

    return data->show_time[dat_size -1];
}

uint32_t Pattern::getPixelColor(uint16_t sequence, uint16_t led_no)
{
    if ((data == nullptr) || (data->max_sequence <= sequence) || (data->led_length <= led_no))
    {
        return 0;
    }

    return data->sequence[sequence].pixel[led_no];
}
