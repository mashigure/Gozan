#include "SerialLED_Array.h"

SerialLED_Array::SerialLED_Array(uint16_t led_num, int16_t pin, neoPixelType type):
    neo_pix(led_num, pin, type),
    counter(),
    led_data(nullptr),
    max_seq(0),
    show_time(0),
    repeat(true),
    current_seq(0),
    is_playing(false)
{
}

void SerialLED_Array::begin(void)
{
    neo_pix.begin();
}

void SerialLED_Array::show(void)
{
    neo_pix.show();
}

void SerialLED_Array::clear(void)
{
    neo_pix.clear();
}

void SerialLED_Array::autoPlay(uint32_t const *data, uint32_t sequens_num, uint32_t one_shot_ms, bool repeat)
{
    if (data != nullptr)
    {
        led_data        = data;
        max_seq         = sequens_num;
        this->show_time = one_shot_ms;
        this->repeat    = repeat;
        is_playing      = true;
        current_seq     = 0u;
        counter.reset(0);
    }
}

bool SerialLED_Array::isPlaying(void)
{
    return is_playing;
}

void SerialLED_Array::setPixelColor(uint32_t const *data, uint16_t sequence)
{
    uint16_t led_num = neo_pix.numPixels();

    for (uint16_t i=0; i<led_num; i++)
    {
        neo_pix.setPixelColor(i, getPixelColor(data, sequence, i));
    }
}

uint32_t SerialLED_Array::getPixelColor(uint32_t const *data, uint16_t sequence, uint16_t led_no)
{
    uint32_t dat_pos = (sequence * neo_pix.numPixels()) + led_no;

    if (data == nullptr)
    {
        return 0u;
    }

    return data[dat_pos];
}

void SerialLED_Array::update(void)
{
    if (is_playing && counter.isCounted())
    {
        if (max_seq <= current_seq)
        {
            if (repeat)
            {
                /* restart */
                is_playing  = true;
                current_seq = 0;
            }
            else
            {
                is_playing = false;
                return;
            }
        }

        setPixelColor(led_data, current_seq);
        show();
        counter.reset(show_time);
        current_seq++;
    }
}
