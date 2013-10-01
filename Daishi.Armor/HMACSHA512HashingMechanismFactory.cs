﻿namespace Daishi.Armor {
    public class HMACSHA512HashingMechanismFactory : HashingMechanismFactory {
        public HMACSHA512HashingMechanismFactory(byte[] key, byte[] input) : base(key, input) {}

        public override HashingMechanism CreateHashingMechanism() {
            return new HMACSHA512HashingMechanism(key, input);
        }
    }
}