#include <Adafruit_NeoPixel.h>

#ifndef GOZAN_H
#define GOZAN_H

///----------------------------------------------------------------
/// RGB LED color convert
///----------------------------------------------------------------
#define RGB2PIXEL(r, g, b)  (((r) << 16) | ((g) << 8) | (b))


///----------------------------------------------------------------
/// LED Illumination Pattern (one scene)
///----------------------------------------------------------------
typedef struct
{
    uint32_t const *pixel;          // pixel[led_length];
} Pixel;


///----------------------------------------------------------------
/// LED Illumination Pattern
///----------------------------------------------------------------
typedef struct
{
    uint16_t max_sequence;
    uint16_t led_length;
    int32_t  const *show_time;
    Pixel    const *sequence;       // sequence[max_sequence].pixel[led_length];
} PatternData;


///----------------------------------------------------------------
/// class to management Illumination Patterns
///----------------------------------------------------------------
class Pattern
{
protected:
    PatternData const *data;

public:
    static const int32_t SHOW_INFINITY = -1;

    Pattern();
    Pattern(PatternData const *pattern);
    uint16_t getMaxSequence(void);
    uint16_t getLedLength(void);
    int32_t  getShowTime(uint16_t sequence);
    uint32_t getPixelColor(uint16_t sequence, uint16_t led_no);
};


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
/// Gozan: Utility for NeoPixel Illumination
///----------------------------------------------------------------
class Gozan
{
    Adafruit_NeoPixel neo_pix;
    Pattern           pattern;
    WaitCounter       counter;
    uint32_t          current_seq;
    bool              repeat;
    bool              is_playing;

public:
    Gozan(uint16_t led_num, int16_t pin = 6, neoPixelType type = NEO_GRB + NEO_KHZ800);
    void begin(void);
    void show(void);
    void clear(void);
    void update(void);
    bool isPlaying(void);
    void setPattern(PatternData const *pattern_data, bool repeat = true);
    void setPixelColor(uint16_t sequence);

private:
    void play(void);
};

#endif // GOZAN_H
