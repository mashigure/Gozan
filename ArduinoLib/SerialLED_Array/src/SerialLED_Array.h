#include <Adafruit_NeoPixel.h>

#ifndef SERIALLED_ARRAY_H
#define SERIALLED_ARRAY_H

///----------------------------------------------------------------
/// RGB LED color convert
///----------------------------------------------------------------
#define RGB2PIXEL(r, g, b)  (((r) << 16) | ((g) << 8) | (b))


///----------------------------------------------------------------
/// Counter to wait for next scene
///----------------------------------------------------------------
class WaitCounter
{
    int32_t  wait_time;
    uint32_t reset_time;

public:
    WaitCounter();
    void reset(int32_t wait_ms);
    bool isCounted(void);
};


///----------------------------------------------------------------
/// SerialLED_Array: Utility for NeoPixel Illumination
///----------------------------------------------------------------
class SerialLED_Array
{
    Adafruit_NeoPixel neo_pix;
    WaitCounter       counter;
    const uint32_t *  led_data;
    uint32_t          max_seq;
    uint32_t          show_time;
    bool              repeat;
    uint32_t          current_seq;
    bool              is_playing;

public:
    SerialLED_Array(uint16_t led_num, int16_t pin = 6, neoPixelType type = NEO_GRB + NEO_KHZ800);
    void     begin(void);
    void     show(void);
    void     clear(void);
    void     autoPlay(uint32_t const *data, uint32_t sequens_num, uint32_t one_shot_ms, bool repeat = true);
    bool     isPlaying(void);
    void     setPixelColor(uint32_t const *data, uint16_t sequence);
    uint32_t getPixelColor(uint32_t const *data, uint16_t sequence, uint16_t led_no);
    void     update(void);
};

#endif // SERIALLED_ARRAY_H
