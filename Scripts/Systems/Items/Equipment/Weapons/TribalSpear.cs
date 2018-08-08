using System;

namespace Server.Items
{
    [FlipableAttribute(0xF62, 0xF63)]
    public class TribalSpear : BaseSpear
    {
        [Constructable]
        public TribalSpear()
            : base(0xF62)
        {
            this.Weight = 7.0;
            this.Hue = 837;
        }

        public TribalSpear(Serial serial)
            : base(serial)
        {
        }

        public override int OldStrengthReq
        {
            get
            {
                return 30;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 2;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 36;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 46;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 80;
            }
        }
        public override int VirtualDamageBonus
        {
            get
            {
                return 25;
            }
        }
        public override string DefaultName
        {
            get
            {
                return "a tribal spear";
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}