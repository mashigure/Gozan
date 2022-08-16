#include "Gozan.h"

Gozan::Gozan(uint16_t led_num, int16_t pin, neoPixelType type):
    neo_pix(led_num, pin, type),
    pattern(),
    counter(),
    current_seq(0),
    repeat(true),
    is_playing(false)
{
}

void Gozan::begin(void)
{
    neo_pix.begin();
    counter.reset(0);
}

void Gozan::show(void)
{
    neo_pix.show();
}

void Gozan::clear(void)
{
    neo_pix.clear();
}

void Gozan::update(void)
{
    if (!is_playing && repeat)
    {
        /* restart */
        is_playing  = true;
        current_seq = 0;
        counter.reset(0);
    }

    play();
}

bool Gozan::isPlaying(void)
{
    return is_playing;
}

void Gozan::setPattern(PatternData const *pattern_data, bool repeat)
{
    if (pattern_data != nullptr)
    {
        this->pattern = Pattern(pattern_data);
        this->repeat  = repeat;
        is_playing    = false;
        current_seq   = 0;
        counter.reset(0);
    }
}

void Gozan::setPixelColor(uint16_t sequence)
{
    uint16_t led_num = pattern.getLedLength();

    if (neo_pix.numPixels() < led_num)
    {
        led_num = neo_pix.numPixels();
    }

    for (uint16_t i=0; i<led_num; i++)
    {
        neo_pix.setPixelColor(i, pattern.getPixelColor(sequence, i));
    }
}

// private function
void Gozan::play(void)
{
    if (is_playing && counter.isCounted())
    {
        if (pattern.getMaxSequence() <= current_seq)
        {
            is_playing = false;
            return;
        }

        setPixelColor(current_seq);
        show();

        int32_t delay_time = pattern.getShowTime(current_seq);

        if (0 <= delay_time)
        {
            counter.reset(delay_time);
        }
        else
        {
            /* stop playing */
            this->repeat = false;
            is_playing   = false;
        }

        current_seq++;
    }
}
