//
//  RNSystemAddress.m
//  MCPEServer
//
//  Created by Sergey Abramchuk on 24.12.15.
//  Copyright © 2015 ss-abramchuk. All rights reserved.
//

#import "RNSystemAddress.h"
#import "RNSystemAddress+Internal.h"

@interface RNSystemAddress () {
    SystemAddress *_systemAddress;
}

@end

@implementation RNSystemAddress (Internal)

- (SystemAddress *)systemAddress {
    return _systemAddress;
}

- (instancetype)initWithSystemAddress:(SystemAddress)systemAddress {
    self = [super init];
    if (self) {
        _systemAddress = new SystemAddress;
        *_systemAddress = systemAddress;
    }
    return self;
}

@end

@implementation RNSystemAddress

- (NSString *)address {
    const char *address = self.systemAddress->ToString(false);
    return [NSString stringWithUTF8String:address];
}

- (unsigned short)port {
    return self.systemAddress->GetPort();
}

- (instancetype)init
{
    self = [super init];
    if (self) {
        _systemAddress = new SystemAddress();
    }
    return self;
}

- (instancetype)initWithAddress:(NSString *)address {
    self = [super init];
    if (self) {
        _systemAddress = new SystemAddress([address UTF8String]);
    }
    return self;
}

- (instancetype)initWithAddress:(NSString *)address andPort:(unsigned short)port {
    self = [super init];
    if (self) {
        _systemAddress = new SystemAddress([address UTF8String], port);
    }
    return self;
}

- (BOOL)isEqual:(id)other {
    if ([other isKindOfClass:[RNSystemAddress class]] &&
        *((RNSystemAddress *)other).systemAddress == *self.systemAddress) {
        return YES;
    } else {
        return NO;
    }
}

- (NSUInteger)hash {
    return SystemAddress::ToInteger(*self.systemAddress);
}

- (void)dealloc {
    delete _systemAddress;
}

@end