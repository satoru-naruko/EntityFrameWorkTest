using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkTest1.Model { 
    [Table("menu",Schema ="public")] // テーブルの名前を入力。
    public class Menu
    {
        [Key] // 主キーを設定。
        [Column("id")] // データベース上のカラム名を入力。
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("price")]
        public int Price { get; set; }

        [Column("modify_datetime")]
        public DateTime ModifyDateTime { get; set; }

        [Column("create_datetime")]
        public DateTime CreateDateTime { get; set; }
    }
}
