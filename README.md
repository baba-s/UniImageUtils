# UniImageUtils

Image 型に関係する汎用的な関数を管理するクラス

## 使用例

```cs
using Kogane;
using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    public Image m_image;

    private void Awake()
    {
        // Inspector で「It looks like~」が表示されている場合 true
        Debug.Log( ImageUtils.IsTiledWithNoBorder( m_image ) );
    }
}
```
![2020-10-06_210706](https://user-images.githubusercontent.com/6134875/95199491-db36be00-0817-11eb-8382-3d0926066180.png)
