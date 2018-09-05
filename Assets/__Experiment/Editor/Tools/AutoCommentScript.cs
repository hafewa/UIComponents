#region ģ����Ϣ
/*----------------------------------------------------------------
// Copyright (C) 2015 ����
//
// ģ������    AutoCommentScript
// �����ߣ�    ���ڷ�
// ���䣺      smallrainf@gmail.com
// �޸����б�
// �������ڣ�  2016-01-05 22:21:38
// ģ��������
//----------------------------------------------------------------*/
#endregion

using System.IO;
using System.Text;

public class AutoCommentScript : UnityEditor.AssetModificationProcessor
{
    public static void OnWillCreateAsset( string path )
    {
        string[] segments = path.Split( '.' );
        if ( segments[1] != "cs" )
            return;

        string filename = segments[0] + "." + segments[1];
        string content = File.ReadAllText( filename, Encoding.UTF8 );
        content = content.Replace( "#SCRIPTDATE#", System.DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" ) );
        File.WriteAllText( filename, content, Encoding.UTF8 );
    }
}
