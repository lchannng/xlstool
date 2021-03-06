# xlstool
Excel配置读取工具

### 功能
1. 根据excel表头定义生成protobuf定义
2. 导出excel数据，并保存通过pb序列化后数据到文件
3. 自动生成CS、CPP等语言读取配置的代码

### 说明

* 每个excel工作簿可以建多张表，每张表都导出生成一个描述表头的结构，并生成proto文件
* 跳过以"#", "_", "Sheet"开头的表，不导出数据和proto文件

### 表头定义
|第1行{desc}    | 字段描述1                  | 字段描述2                     |
|:-------------:|:--------------------------:|:-----------------------------:|
|第2行{name}    | 字段名称1                  | 字段名称2                     |
|第3行{type}    | 数据类型                   | 数据类型属性名                |
|第4行{tag}     | 数据标签                   | 数据标签                      |
|第5行{index}   | 是否设置为索引(1/0)        | 是否设置为索引(1/0)           |
|第6行{index}   | 是否设置为索引(1/0)        | 是否设置为索引(1/0)           |
|第7行{index}   | 是否设置为索引(1/0)        | 是否设置为索引(1/0)           |

* 前四行固定为字段描述、字段名称、数据类型、数据标签
* 支持的数据类型：int32, int64, float, double, string(对应protobuf数据类型)
* 数据标签用来指定该标签所属组，可为任意字符，当导出数据时添加 -t c 选项，只导出数据标签中有c的列
* (该功能正在实现){index}行用来生成读取数据的方法，可有多行{index}，每个index行对应生成一个索引数据的方法,
如表Example

将会生成 ConfigData.Example(int id1)，ConfigData.Example_1(int id2, int id3)两个方法，根据不同字段索引数据

|         |id1   | id2  | id3  |
|:-------:|:----:|:----:|:----:|
|{index}  | 1    |      |      |
|{index}  |      |  1   |  1   |


### 依赖
* python
* protoc
* xlrd
 ``pip install xlrd``

* python-protobuf

 ``pip install protobuf``

### Usage

```
python ./src/xlstool.py [options] ./output
```

example:
```
python ./src/xlstool.py -t c -o cpp --package_name=MyGame --loader_name=ConfigData -p ./example/xls ./output

python ./src/xlstool.py -t c -o cpp --package_name=MyGame --loader_name=ConfigData -f ./xls_lists.txt ./output
```

option:

    -h, --help

    -t, --tag=              Only export fields which has the tag(只导出带有tag的字段)

    -o, --output=cs,cpp     Generate cs,cpp bindings (生成csharp, cpp读取数据相关代码)

        --loader_name=      Config loader class name (用于读取数据的类的名称, 二进制数据文件名称, 默认DataCenter)

        --package_name=     Proto package name (proto包名, 默认AppConfig)
    -f, --file_list=xls_list.txt        xls file list (xls列表, 导出列表中的xls文件)
    -p, --xls_path=path     export all xls file from this path (导出目录下所有xls文件)
        --proto_syntax=     proto syntax: proto2 or proto3


### 运行示例

``./run.sh``

### 在程序中读取数据

unity2017开启net45, 使用官方protobuf。

```cs
using UnityEngine;
using MyGame;

public class ProtoDemo : MonoBehaviour {

	void Start () {
        // 读取二进制数据
        var ta = Resources.Load<TextAsset>("ConfigData");

        // 初始化数据中心
        ConfigData.Init(ta.bytes);

        var goods = ConfigData.GoodsFind(3400);
        Debug.LogFormat("goods 3400: {0}", goods.ToString());

        var skill = ConfigData.SkillFind(12020);
        Debug.LogFormat("skill 12020 {0}", skill.ToString());

        for (int i = 0; i < ConfigData.GoodsCount(); ++i)
        {
            var g = ConfigData.GoodsItem(i);
            Debug.LogFormat("goods iteration {0}: {1}", i, g.ToString());
        }
	}

}
```

### 自定义codegen

参照src/codegen目录下例子自造，实现
```python
def gen_code(package_name, loader_name,
             datablocks_name, all_sheet_metas, output_path):
    pass
```

修改src/xlstool.py

```python
def process_xls_files(xls_files, tag, output):
    ...

    if "xxx" in output:
        from codegen import xxx_codegen
        xxx_codegen.gen_code(PACKAGE_NAME, LOADER_CLASS_NAME,
                             DATA_BLOCKS_STRUCT_NAME, all_sheet_metas, CPP_OUTPUT_PATH)
    ...

```
