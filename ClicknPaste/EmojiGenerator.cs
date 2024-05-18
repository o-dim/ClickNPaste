using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClicknPaste
{
    internal class EmojiGenerator
    {
        private static Random random = new Random();

        public string RandEmoji()
        {
            string[] emojis = { "ฅʕ◍·̀·́◍ʔฅ", "ദ്ദി・ᴗ・)✧" , "⸜( ⌓̈ )⸝", "໒꒰ྀི ˃ ᵕ ˂ ꒱ྀི১", "ヾ꒰ྀི *ˊᵕˋ ꒱ྀིﾉ", "ꉂꉂ (*ˊᗜˋ*)", "٩(͡๏̯͡๏)۶",
                                "₍♡•͈ᴗ•͈♡₎", "(ෆ`ᵕ´ෆ)",  "٩꒰｡•‿•｡꒱۶", "꒰◍ᐡᐤᐡ◍꒱"};
            int index = random.Next(emojis.Length); // 배열의 길이 내에서 랜덤한 인덱스 선택
            return emojis[index]; // 선택된 이모지 반환
        }
    }
}
